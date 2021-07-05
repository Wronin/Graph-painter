using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testGraphics
{
    public partial class Form1 : Form
    {
        private int size = 21;
        private int offsetX = 0;
        private int offsetY = 0;
        private Point currentPoint;
        private int numberOfPoint = 99999;
        Bitmap bitmap;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        public struct GraphPoint
        {
            public int X;
            public int Y;

            public GraphPoint(int _x, int _y)
            {
                X = _x;
                Y = _y;
            }
        }

        List<Rectangle> rectangles = new List<Rectangle>();
        List<GraphPoint> graphPoints = new List<GraphPoint>();
        Point[] points;

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            Pen MainPen = new Pen(Color.Black, 2);
            Pen silverPen = new Pen(Color.Silver, 1);

            for (int i = 0; i < pictureBox1.Height / 2;)
            {
                graphics.DrawLine(silverPen, 0, i * GetSize() + pictureBox1.Height / 2 + offsetY, pictureBox1.Width, i * GetSize() + pictureBox1.Height / 2 + offsetY);
                graphics.DrawLine(silverPen, 0, pictureBox1.Height / 2 - i * GetSize() + offsetY, pictureBox1.Width, pictureBox1.Height / 2 - i * GetSize() + offsetY);
                i++;
            }

            for (int i = 0; i < pictureBox1.Width / 2;)
            {
                graphics.DrawLine(silverPen, i * GetSize() + pictureBox1.Width / 2 + offsetX, 0, i * GetSize() + pictureBox1.Width / 2 + offsetX, pictureBox1.Height);
                graphics.DrawLine(silverPen, pictureBox1.Width / 2 - i * GetSize() + offsetX, 0, pictureBox1.Width / 2 - i * GetSize() + offsetX, pictureBox1.Height);
                i++;
            }


            graphics.DrawLine(MainPen, 0, pictureBox1.Height / 2 + offsetY, pictureBox1.Width, pictureBox1.Height / 2 + offsetY);
            graphics.DrawLine(MainPen, pictureBox1.Width / 2 + offsetX, 0, pictureBox1.Width / 2 + offsetX, pictureBox1.Height);

            pictureBox1.Image = bitmap;

            graphPoints.Add(new GraphPoint(-3, 9));
            graphPoints.Add(new GraphPoint(-2, 4));
            graphPoints.Add(new GraphPoint(-1, 1));
            graphPoints.Add(new GraphPoint(0, 0));
            graphPoints.Add(new GraphPoint(1, 1));
            graphPoints.Add(new GraphPoint(2, 4));
            graphPoints.Add(new GraphPoint(3, 9));


            //DataTableGrid.AllowUserToAddRows = false;
            DataTable table = new DataTable();
            table.Columns.Add("X", typeof(int));
            table.Columns.Add("Y", typeof(int));


            for (int i = 0; i < graphPoints.Count; i++)
            {
                table.Rows.Add(graphPoints[i].X, graphPoints[i].Y);
            }

            DataTableGrid.DataSource = table;
            DataTableGrid.Columns[0].Width = 60;
            DataTableGrid.Columns[1].Width = 60;
        }

        private void DrawGraph_Click(object sender, EventArgs e)
        {
            points = new Point[DataTableGrid.RowCount];
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            Pen MainPen = new Pen(Color.Black, 2);
            Pen silverPen = new Pen(Color.Silver, 1);

            for (int i = 0; i < pictureBox1.Height / 2;)
            {
                graphics.DrawLine(silverPen, 0, i * GetSize() + pictureBox1.Height / 2 + offsetY, pictureBox1.Width, i * GetSize() + pictureBox1.Height / 2 + offsetY);
                graphics.DrawLine(silverPen, 0, pictureBox1.Height / 2 - i * GetSize() + offsetY, pictureBox1.Width, pictureBox1.Height / 2 - i * GetSize() + offsetY);
                i++;
            }

            for (int i = 0; i < pictureBox1.Width / 2;)
            {
                graphics.DrawLine(silverPen, i * GetSize() + pictureBox1.Width / 2 + offsetX, 0, i * GetSize() + pictureBox1.Width / 2 + offsetX, pictureBox1.Height);
                graphics.DrawLine(silverPen, pictureBox1.Width / 2 - i * GetSize() + offsetX, 0, pictureBox1.Width / 2 - i * GetSize() + offsetX, pictureBox1.Height);
                i++;
            }

            graphics.DrawLine(MainPen, 0, pictureBox1.Height / 2 + offsetY, pictureBox1.Width, pictureBox1.Height / 2 + offsetY);
            graphics.DrawLine(MainPen, pictureBox1.Width / 2 + offsetX, 0, pictureBox1.Width / 2 + offsetX, pictureBox1.Height);


            Pen MainGraphPen = new Pen(Color.Red, 3);
            Pen bPen = new Pen(Color.Blue, 5);
            //Brush brush = new Brush(Color.White);


            graphPoints.Clear();
            int x = -9999, x1 = 9999, y = -9999, y1 = 9999;
            if (TxtBoxX.Text != "")
                x = Convert.ToInt32(TxtBoxX.Text);
            if (TxtBoxX1.Text != "")
                x1 = Convert.ToInt32(TxtBoxX1.Text);
            if (TxtBoxY.Text != "")
                y = Convert.ToInt32(TxtBoxY.Text);
            if (TxtBoxY1.Text != "")
                y1 = Convert.ToInt32(TxtBoxY1.Text);

            for (int i = 0; i < DataTableGrid.RowCount - 1; i++)
            {
                graphPoints.Add(new GraphPoint(Convert.ToInt32(DataTableGrid[0,i].Value.ToString()), Convert.ToInt32(DataTableGrid[1, i].Value.ToString())));
                if (x <= graphPoints[i].X && graphPoints[i].X <= x1 && y <= graphPoints[i].Y && graphPoints[i].Y <= y1)
                    points[i] = new Point(graphPoints[i].X * GetSize() + pictureBox1.Width / 2 + offsetX, pictureBox1.Height / 2 - graphPoints[i].Y * GetSize() + offsetY);
                else
                    points[i] = new Point(0, 0);
            }
            
            for (int i = 0; i < points.Length - 1; i++)
            {
                if (points[i].X != 0 && points[i].Y != 0 && points[i + 1].X != 0 && points[i + 1].Y != 0)
                    graphics.DrawLine(MainGraphPen, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].X != 0 && points[i].Y != 0)
                    graphics.DrawEllipse(bPen, points[i].X, points[i].Y, 1, 1);
            }
            pictureBox1.Image = bitmap;
        }

        private void CombineBitmap(Bitmap bitmap, Graphics graphics)
        {
            
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            size += 5;
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            size -= 5;
        }

        private int GetSize()
        {
            return size;
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            offsetY -= GetSize();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            offsetX -= GetSize();
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            offsetY += GetSize();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            offsetX += GetSize();
        }
        private Bitmap GetBitmap()
        {
            return bitmap;
        }
        private Graphics GetGraphics()
        {
            return graphics;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataTableGrid.SelectedRows)
            {
                DataTableGrid.Rows.RemoveAt(row.Index);
            }
        }

        private void DrawGrid(Bitmap bitmap, Graphics graphics)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            Pen MainPen = new Pen(Color.Black, 2);
            Pen silverPen = new Pen(Color.Silver, 1);

            for (int i = 0; i < pictureBox1.Height / 2;)
            {
                graphics.DrawLine(silverPen, 0, i * GetSize() + pictureBox1.Height / 2 + offsetY, pictureBox1.Width, i * GetSize() + pictureBox1.Height / 2 + offsetY);
                graphics.DrawLine(silverPen, 0, pictureBox1.Height / 2 - i * GetSize() + offsetY, pictureBox1.Width, pictureBox1.Height / 2 - i * GetSize() + offsetY);
                i++;
            }

            for (int i = 0; i < pictureBox1.Width / 2;)
            {
                graphics.DrawLine(silverPen, i * GetSize() + pictureBox1.Width / 2 + offsetX, 0, i * GetSize() + pictureBox1.Width / 2 + offsetX, pictureBox1.Height);
                graphics.DrawLine(silverPen, pictureBox1.Width / 2 - i * GetSize() + offsetX, 0, pictureBox1.Width / 2 - i * GetSize() + offsetX, pictureBox1.Height);
                i++;
            }


            graphics.DrawLine(MainPen, 0, pictureBox1.Height / 2 + offsetY, pictureBox1.Width, pictureBox1.Height / 2 + offsetY);
            graphics.DrawLine(MainPen, pictureBox1.Width / 2 + offsetX, 0, pictureBox1.Width / 2 + offsetX, pictureBox1.Height);

            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PrintGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK  )
                doc.Print();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
            bitmap.Dispose();
        }

        private void LoadGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                graphPoints.Clear();
                BinaryReader reader = new BinaryReader(new FileStream(ofd.FileName, FileMode.Open));
                int count = reader.ReadInt32();

                for (int i = 0; i < count; i++)
                {
                    graphPoints.Add(new GraphPoint(reader.ReadInt32(), reader.ReadInt32()));
                }

                DataTable table = new DataTable();
                table.Columns.Add("X", typeof(int));
                table.Columns.Add("Y", typeof(int));

                for (int i = 0; i < graphPoints.Count; i++)
                {
                    table.Rows.Add(graphPoints[i].X, graphPoints[i].Y);
                }
                DataTableGrid.DataSource = table;
            }


        }

        private void SaveTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                BinaryWriter write = new BinaryWriter(new FileStream(sfd.FileName + ".Golakhov", FileMode.OpenOrCreate));

                write.Write(graphPoints.Count);

                for (int i = 0; i < graphPoints.Count; i++)
                {
                    write.Write(graphPoints[i].X);
                    write.Write(graphPoints[i].Y);
                }

                write.Close();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < graphPoints.Count; i++)
            {
                if (points[i].X == e.X && points[i].Y == e.Y)
                {
                    currentPoint = new Point(points[i].X, points[i].Y);
                    numberOfPoint = i;
                    break;
                }

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (numberOfPoint != 99999)
            {
                currentPoint = new Point(e.X, e.Y);
            }
            Coordinates.Text = e.X + " ;" + e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (numberOfPoint != 99999)
            {
                graphPoints[numberOfPoint] = new GraphPoint((int)Math.Round((double)(e.X - (pictureBox1.Width / 2)) / GetSize()), (int)Math.Round((double)((pictureBox1.Height / 2) - e.Y) / GetSize()));
                DataTableGrid[0, numberOfPoint].Value = graphPoints[numberOfPoint].X;
                DataTableGrid[1, numberOfPoint].Value = graphPoints[numberOfPoint].Y;
                points[numberOfPoint] = new Point((int)currentPoint.X, (int)currentPoint.Y);
                numberOfPoint = 99999;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coordinates.Text = graphPoints[3].X + " " + graphPoints[3].Y + " ;" + points[3].X + " " + points[3].Y;
        }

    
    }
}
