using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using static lab6.Form1;

namespace lab6
{
    public partial class Form1 : Form
    {
        Polyhedron polyhedron;
        private TransformationMatrix currentProjectionMatrix;
        private List<Point3D> line = new List<Point3D>();
        private bool IsPersp = true;
        int del = 50;

        public Form1()
        {
            InitializeComponent();
            polyhedron = CreateIcosahedron();

            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);

            txtOffsetX.KeyPress += ApplyTranslation;
            txtOffsetY.KeyPress += ApplyTranslation;
            txtOffsetZ.KeyPress += ApplyTranslation;

            txtRotationX.KeyPress += ApplyRotation;
            txtRotationY.KeyPress += ApplyRotation;
            txtRotationZ.KeyPress += ApplyRotation;

            txtScaleX.KeyPress += ApplyScaling;
            txtScaleY.KeyPress += ApplyScaling;
            txtScaleZ.KeyPress += ApplyScaling;

            firstPointX.KeyPress += ChangeFirstPoint;
            firstPointY.KeyPress += ChangeFirstPoint;
            firstPointZ.KeyPress += ChangeFirstPoint;

            secondPointX.KeyPress += ChangeSecondPoint;
            secondPointY.KeyPress += ChangeSecondPoint;
            secondPointZ.KeyPress += ChangeSecondPoint;

            txtAngle.KeyPress += ChangeAngle;

            currentProjectionMatrix = TransformationMatrix.PerspectiveProjection(del);
            comboBox1.Items.Add("Центральная");
            comboBox1.Items.Add("Аксонометрическая");
            comboBox1.SelectedItem = "Центральная";
            comboBox1.SelectedIndex = 0;

            pictureBox1.Invalidate();
        }

        // Класс точки
        public class Point3D
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

        // Класс грани
        public class Face
        {
            public List<int> Vertices { get; set; }

            public Face(List<int> vertices)
            {
                Vertices = vertices;
            }
        }

        // Класс многогранника
        public class Polyhedron
        {
            public List<Point3D> Vertices { get; set; } //точки
            public List<Face> Faces { get; set; } //грани

            public Polyhedron()
            {
                Vertices = new List<Point3D>();
                Faces = new List<Face>();
            }

            public Polyhedron(List<Point3D> vertices, List<Face> faces)
            {
                Vertices = vertices;
                Faces = faces;
            }
        }

        // Класс матрицы афинных преобразований
        // =========================================================================
        public class TransformationMatrix
        {
            public double[,] matrix = new double[4, 4];

            public TransformationMatrix()
            {
                matrix[0, 0] = 1;
                matrix[1, 1] = 1;
                matrix[2, 2] = 1;
                matrix[3, 3] = 1;
            }


            public Point3D Transform(Point3D p)
            {
                double x = matrix[0, 0] * p.X + matrix[1, 0] * p.Y + matrix[2, 0] * p.Z + matrix[3, 0];
                double y = matrix[0, 1] * p.X + matrix[1, 1] * p.Y + matrix[2, 1] * p.Z + matrix[3, 1];
                double z = matrix[0, 2] * p.X + matrix[1, 2] * p.Y + matrix[2, 2] * p.Z + matrix[3, 2];

                return new Point3D(x, y, z);
            }


            public Point3D TransformForPerspect(Point3D p)
            {
                double x = matrix[0, 0] * p.X + matrix[1, 0] * p.Y + matrix[2, 0] * p.Z + matrix[3, 0];
                double y = matrix[0, 1] * p.X + matrix[1, 1] * p.Y + matrix[2, 1] * p.Z + matrix[3, 1];
                double z = matrix[0, 2] * p.X + matrix[1, 2] * p.Y + matrix[2, 2] * p.Z + matrix[3, 2];
                double w = matrix[0, 3] * p.X + matrix[1, 3] * p.Y + matrix[2, 3] * p.Z + matrix[3, 3];

                if (w != 0)
                {
                    x /= w;
                    y /= w;
                    z /= w;
                }

                return new Point3D(x, y, z);
            }

            public static TransformationMatrix PerspectiveProjection(double distance)
            {
                // Перспективная проекция
                TransformationMatrix result = new TransformationMatrix();
                //result.matrix[0, 0] = 1;
                //result.matrix[1, 1] = 1;
                //result.matrix[2, 2] = 1;
                //result.matrix[2, 3] = 1 / distance; // Устанавливаем масштаб по Z
                //result.matrix[3, 2] = -1;
                //result.matrix[3, 3] = 0;

                result.matrix[0, 0] = 1;
                result.matrix[1, 1] = 1;
                result.matrix[3, 2] = 1/distance;
                result.matrix[3, 3] = 1;
                return result;
            }

            public static TransformationMatrix AxonometricProjection(double theta, double phi)
            {
                // преобразуем углы из градусов в радианы
                double cosTheta = Math.Cos(theta * Math.PI / 180);
                double sinTheta = Math.Sin(theta * Math.PI / 180);
                double cosPhi = Math.Cos(phi * Math.PI / 180);
                double sinPhi = Math.Sin(phi * Math.PI / 180);

                TransformationMatrix result = new TransformationMatrix();
                result.matrix[0, 0] = cosTheta;
                result.matrix[0, 1] = sinTheta * sinPhi;
                result.matrix[1, 1] = cosPhi;
                result.matrix[2, 0] = sinTheta;
                result.matrix[2, 1] = -cosTheta * sinPhi;
                result.matrix[2, 2] = 0;
                return result;
            }

            public static TransformationMatrix Multiply(TransformationMatrix a, TransformationMatrix b)
            {
                TransformationMatrix result = new TransformationMatrix();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        result.matrix[i, j] = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            result.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                        }
                    }
                }
                return result;
            }

            public static TransformationMatrix CreateTranslationMatrix(double dx, double dy, double dz)
            {
                TransformationMatrix result = new TransformationMatrix();
                result.matrix[3, 0] = dx;
                result.matrix[3, 1] = dy;
                result.matrix[3, 2] = dz;
                return result;
            }

            public static TransformationMatrix CreateScalingMatrix(double scaleX, double scaleY, double scaleZ)
            {
                TransformationMatrix result = new TransformationMatrix();
                result.matrix[0, 0] = scaleX;
                result.matrix[1, 1] = scaleY;
                result.matrix[2, 2] = scaleZ;
                return result;
            }

            public static TransformationMatrix CreateScalingMatrix(double scaleX, double scaleY, double scaleZ, Point3D center)
            {
                var translateToOrigin = CreateTranslationMatrix(-center.X, -center.Y, -center.Z);
                var scalingMatrix = CreateScalingMatrix(scaleX, scaleY, scaleZ);
                var translateBack = CreateTranslationMatrix(center.X, center.Y, center.Z);

                return Multiply(Multiply(translateToOrigin, scalingMatrix), translateBack);
            }


            public static TransformationMatrix CreateRotationMatrixX(double angle)
            {
                double radians = angle * Math.PI / 180;
                TransformationMatrix result = new TransformationMatrix();
                double cos = Math.Cos(radians);
                double sin = Math.Sin(radians);
                result.matrix[1, 1] = cos;
                result.matrix[1, 2] = -sin;
                result.matrix[2, 1] = sin;
                result.matrix[2, 2] = cos;
                return result;
            }

            public static TransformationMatrix CreateRotationMatrixY(double angle)
            {
                double radians = angle * Math.PI / 180;
                TransformationMatrix result = new TransformationMatrix();
                double cos = Math.Cos(radians);
                double sin = Math.Sin(radians);
                result.matrix[0, 0] = cos;
                result.matrix[0, 2] = -sin;
                result.matrix[2, 0] = sin;
                result.matrix[2, 2] = cos;
                return result;
            }

            public static TransformationMatrix CreateRotationMatrixZ(double angle)
            {
                double radians = angle * Math.PI / 180;
                TransformationMatrix result = new TransformationMatrix();
                double cos = Math.Cos(radians);
                double sin = Math.Sin(radians);
                result.matrix[0, 0] = cos;
                result.matrix[0, 1] = sin;
                result.matrix[1, 0] = -sin;
                result.matrix[1, 1] = cos;
                return result;
            }


            public static TransformationMatrix CreateRotationMatrix(double angleX, double angleY, double angleZ)
            {
                var rotationX = CreateRotationMatrixX(angleX);
                var rotationY = CreateRotationMatrixY(angleY);
                var rotationZ = CreateRotationMatrixZ(angleZ);
                return Multiply(Multiply(rotationX, rotationY), rotationZ);
            }

            public static TransformationMatrix CreateRotationAroundAxis(double angleX, double angleY, double angleZ, Point3D center)
            {
                TransformationMatrix translateToOrigin = CreateTranslationMatrix(-center.X, -center.Y, -center.Z);
                TransformationMatrix rotationMatrix = CreateRotationMatrix(angleX, angleY, angleZ);
                TransformationMatrix translateBack = CreateTranslationMatrix(center.X, center.Y, center.Z);
                return Multiply(Multiply(translateToOrigin, rotationMatrix), translateBack);
            }


            public static TransformationMatrix CreateReflectionMatrixXY()
            {
                TransformationMatrix result = new TransformationMatrix();
                result.matrix[2, 2] = -1;  // Отражение относительно плоскости XY меняет знак координаты Z
                return result;
            }

            public static TransformationMatrix CreateReflectionMatrixXY(Point3D center)
            {
                TransformationMatrix translateToOrigin = CreateTranslationMatrix(-center.X, -center.Y, -center.Z);
                TransformationMatrix reflectionMatrix = CreateReflectionMatrixXY();
                TransformationMatrix translateBack = CreateTranslationMatrix(center.X, center.Y, center.Z);
                return Multiply(Multiply(translateToOrigin, reflectionMatrix), translateBack);
            }


            public static TransformationMatrix CreateReflectionMatrixXZ()
            {
                TransformationMatrix result = new TransformationMatrix();
                result.matrix[1, 1] = -1;  // Отражение относительно плоскости XZ меняет знак координаты Y
                return result;
            }

            public static TransformationMatrix CreateReflectionMatrixXZ(Point3D center)
            {
                TransformationMatrix translateToOrigin = CreateTranslationMatrix(-center.X, -center.Y, -center.Z);
                TransformationMatrix reflectionMatrix = CreateReflectionMatrixXZ();
                TransformationMatrix translateBack = CreateTranslationMatrix(center.X, center.Y, center.Z);
                return Multiply(Multiply(translateToOrigin, reflectionMatrix), translateBack);
            }

            public static TransformationMatrix CreateReflectionMatrixYZ()
            {
                TransformationMatrix result = new TransformationMatrix();
                result.matrix[0, 0] = -1;  // Отражение относительно плоскости YZ меняет знак координаты X
                return result;
            }

            public static TransformationMatrix CreateReflectionMatrixYZ(Point3D center)
            {
                TransformationMatrix translateToOrigin = CreateTranslationMatrix(-center.X, -center.Y, -center.Z);
                TransformationMatrix reflectionMatrix = CreateReflectionMatrixYZ();
                TransformationMatrix translateBack = CreateTranslationMatrix(center.X, center.Y, center.Z);
                return Multiply(Multiply(translateToOrigin, reflectionMatrix), translateBack);
            }

            public static TransformationMatrix CreateRotationAroundLine(Point3D p1, Point3D p2, double angle)
            {
                double n = p2.X - p1.X;
                double m = p2.Y - p1.Y;
                double l = p2.Z - p1.Z;

                double length = Math.Sqrt(l * l + m * m + n * n);
                l /= length;
                m /= length;
                n /= length;
                double d = Math.Sqrt(m * m + n * n);

                double cosY = l;
                double sinY = -d;

                var rotateY = new TransformationMatrix();
                rotateY.matrix[0, 0] = cosY;
                rotateY.matrix[0, 2] = sinY;
                rotateY.matrix[2, 0] = -sinY;
                rotateY.matrix[2, 2] = cosY;

                double cosX = n / d;
                double sinX = m / d;

                var rotateX = new TransformationMatrix();
                rotateX.matrix[1, 1] = cosX;
                rotateX.matrix[1, 2] = -sinX;
                rotateX.matrix[2, 1] = sinX;
                rotateX.matrix[2, 2] = cosX;

                var translateToOrigin = CreateTranslationMatrix(-p1.X, -p1.Y, -p1.Z);
                var rotationAroundZ = CreateRotationMatrixZ(angle);
                var translateBack = CreateTranslationMatrix(p1.X, p1.Y, p1.Z);

                var inverseRotateY = new TransformationMatrix();
                inverseRotateY.matrix[0, 0] = cosY;
                inverseRotateY.matrix[0, 2] = -sinY;
                inverseRotateY.matrix[2, 0] = sinY;
                inverseRotateY.matrix[2, 2] = cosY;

                var inverseRotateX = new TransformationMatrix();
                inverseRotateX.matrix[1, 1] = cosX;
                inverseRotateX.matrix[1, 2] = sinX;
                inverseRotateX.matrix[2, 1] = -sinX;
                inverseRotateX.matrix[2, 2] = cosX;

                return Multiply(Multiply(Multiply(Multiply(Multiply(Multiply(translateToOrigin, rotateY), rotateX), rotationAroundZ),
                    inverseRotateX), inverseRotateY), translateBack);
            }
        }

        public Polyhedron CreateIcosahedron()
        {
            List<Point3D> vertices = new List<Point3D>();
            List<Face> faces = new List<Face>();

            double radius = 100.0;  
            double height = radius / 2.0;
            double sqrt5 = Math.Sqrt(5) / 2.0 * radius;

            // нижняя окружность Z = -height
            for (int i = 0; i < 5; i++)
            {
                double angle = 2 * Math.PI * i / 5;
                double x = radius * Math.Cos(angle);
                double y = radius * Math.Sin(angle);
                vertices.Add(new Point3D(x, y, -height));
            }

            // верхняя окружность Z = +height
            for (int i = 0; i < 5; i++)
            {
                double angle = 2 * Math.PI * (i + 0.5) / 5; // Смещаем на полуградуса
                double x = radius * Math.Cos(angle);
                double y = radius * Math.Sin(angle);
                vertices.Add(new Point3D(x, y, height));
            }

            // Добавляем две вершины на оси Z
            vertices.Add(new Point3D(0, 0, sqrt5));  // Верхняя вершина Z = sqrt(5)/2 * radius
            vertices.Add(new Point3D(0, 0, -sqrt5)); // Нижняя вершина Z = -sqrt(5)/2 * radius

            // Создаем грани
            for (int i = 0; i < 5; i++)
            {
                int next = (i + 1) % 5;

                // Соединяем нижний и верхний пояс
                faces.Add(new Face(new List<int> { i, next, i + 5 }));
                faces.Add(new Face(new List<int> { next, next + 5, i + 5 }));
            }

            // Соединяем верхнюю и нижнюю вершины с поясом
            for (int i = 0; i < 5; i++)
            {
                faces.Add(new Face(new List<int> { 10, i + 5, (i + 1) % 5 + 5 })); // Верхняя вершина с верхним поясом
                faces.Add(new Face(new List<int> { 11, i, (i + 1) % 5 }));          // Нижняя вершина с нижним поясом
            }

            // Центрирование координат
            double offsetX = pictureBox1.Width / 2;
            double offsetY = pictureBox1.Height / 2;
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i] = new Point3D(vertices[i].X + offsetX, vertices[i].Y + offsetY, vertices[i].Z);
            }

            return new Polyhedron(vertices, faces);
        }


        // Отрисовка многогранников
        // =========================================================================
        public PointF Project(Point3D point, TransformationMatrix projectionMatrix)
        {

                Point3D projectedPoint = projectionMatrix.TransformForPerspect(point);
                return new PointF((float)projectedPoint.X, (float)projectedPoint.Y);
            
        }


        public PointF ProjectLinePoint(Point3D point, TransformationMatrix projectionMatrix)
        {
            Point3D projectedPoint = projectionMatrix.Transform(point);
            return new PointF((float)projectedPoint.X, (float)projectedPoint.Y);
        }


        public void DrawPolyhedron(Polyhedron polyhedron, Graphics g, TransformationMatrix projectionMatrix)
        {
            Pen pen = new Pen(Color.Black, 1);

            foreach (Face face in polyhedron.Faces)
            {
                for (int i = 0; i < face.Vertices.Count; i++)
                {
                    int start = face.Vertices[i];
                    int end = face.Vertices[(i + 1) % face.Vertices.Count];

                    PointF p1 = Project(polyhedron.Vertices[start], projectionMatrix);
                    PointF p2 = Project(polyhedron.Vertices[end], projectionMatrix);

                    g.DrawLine(pen, p1, p2);
                }
            }
        }


        public void DrawStraightLine(Polyhedron polyhedron, Graphics g, TransformationMatrix projectionMatrix)
        {
            Pen pen = new Pen(Color.Red, 2);

            PointF p1 = ProjectLinePoint(line[0], projectionMatrix);
            PointF p2 = ProjectLinePoint(line[1], projectionMatrix);

            g.DrawLine(pen, p1, p2);
        }


        // Обработчик события Paint для отрисовки на pictureBox1
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawPolyhedron(polyhedron, e.Graphics, currentProjectionMatrix);
            if (line.Count == 2)
                DrawStraightLine(polyhedron, e.Graphics, currentProjectionMatrix);
        }


        // Применяем преобразования к многограннику
        // =========================================================================
        public static Point3D GetPolyhedronCenter(Polyhedron p)
        {
            if (p.Vertices == null || p.Vertices.Count == 0)
                return new Point3D(0, 0, 0);

            double sumX = 0, sumY = 0, sumZ = 0;

            foreach (var vertex in p.Vertices)
            {
                sumX += vertex.X;
                sumY += vertex.Y;
                sumZ += vertex.Z;
            }

            int numVertices = p.Vertices.Count;

            double centroidX = sumX / numVertices;
            double centroidY = sumY / numVertices;
            double centroidZ = sumZ / numVertices;

            return new Point3D(centroidX, centroidY, centroidZ);
        }


        private bool TransformPolyhedron(TransformationMatrix transformationMatrix)
        {
            if (polyhedron != null)
            {
                for (int i = 0; i < polyhedron.Vertices.Count; i++)
                {
                    polyhedron.Vertices[i] = transformationMatrix.Transform(polyhedron.Vertices[i]);
                }
                pictureBox1.Invalidate();
                return true;
            }
            return false;
        }

        private void ApplyTranslation(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (double.TryParse(txtOffsetX.Text, out double dx) && double.TryParse(txtOffsetY.Text, out double dy)
                && double.TryParse(txtOffsetZ.Text, out double dz))
                {
                    TransformationMatrix matrix = TransformationMatrix.CreateTranslationMatrix(dx, dy, dz);
                    TransformPolyhedron(matrix);
                }
            }
        }

        private void ApplyRotation(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (double.TryParse(txtRotationX.Text, out double angleX) && double.TryParse(txtRotationY.Text, out double angleY)
                    && double.TryParse(txtRotationZ.Text, out double angleZ))
                {
                    Point3D center = GetPolyhedronCenter(polyhedron);
                    TransformationMatrix matrix = TransformationMatrix.CreateRotationAroundAxis(angleX, angleY, angleZ, center);
                    TransformPolyhedron(matrix);
                }
            }
        }

        private void ApplyScaling(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (double.TryParse(txtScaleX.Text, out double scaleFactorX) && double.TryParse(txtScaleY.Text, out double scaleFactorY)
                    && double.TryParse(txtScaleZ.Text, out double scaleFactorZ))
                {
                    Point3D center = GetPolyhedronCenter(polyhedron);
                    TransformationMatrix matrix = TransformationMatrix.CreateScalingMatrix(scaleFactorX, scaleFactorY, scaleFactorZ, center);
                    TransformPolyhedron(matrix);
                }
            }
        }

        private void cbFlipXY_CheckedChanged(object sender, EventArgs e)
        {
            Point3D center = GetPolyhedronCenter(polyhedron);
            TransformationMatrix matrix = TransformationMatrix.CreateReflectionMatrixXY(center);
            TransformPolyhedron(matrix);
        }

        private void cbFlipXZ_CheckedChanged(object sender, EventArgs e)
        {
            Point3D center = GetPolyhedronCenter(polyhedron);
            TransformationMatrix matrix = TransformationMatrix.CreateReflectionMatrixXZ(center);
            TransformPolyhedron(matrix);
        }

        private void cbFlipYZ_CheckedChanged(object sender, EventArgs e)
        {
            Point3D center = GetPolyhedronCenter(polyhedron);
            TransformationMatrix matrix = TransformationMatrix.CreateReflectionMatrixYZ(center);
            TransformPolyhedron(matrix);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }


        // Поворот вокруг прямой на заданный угол
        // =========================================================================
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (line.Count == 2)
                line.Clear();

            int x = e.Location.X;
            int y = e.Location.Y;
            line.Add(new Point3D(x, y, 0));
            if (line.Count == 1)
            {
                firstPointX.Text = x.ToString();
                firstPointY.Text = y.ToString();
                firstPointZ.Text = "0";

                secondPointX.Text = "0";
                secondPointY.Text = "0";
                secondPointZ.Text = "0";
            }
            else if (line.Count == 2)
            {
                secondPointX.Text = x.ToString();
                secondPointY.Text = y.ToString();
                secondPointZ.Text = "0";
                pictureBox1.Invalidate();
            }
        }


        private void ChangeFirstPoint(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (double.TryParse(firstPointX.Text, out double x) && double.TryParse(firstPointY.Text, out double y)
                    && double.TryParse(firstPointZ.Text, out double z))
                {
                    line[0] = new Point3D(x, y, z);
                    pictureBox1.Invalidate();
                }
            }
        }

        private void ChangeSecondPoint(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (double.TryParse(secondPointX.Text, out double x) && double.TryParse(secondPointY.Text, out double y)
                    && double.TryParse(secondPointZ.Text, out double z))
                {
                    line[1] = new Point3D(x, y, z);
                    pictureBox1.Invalidate();
                }
            }
        }


        private void ChangeAngle(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (double.TryParse(txtAngle.Text, out double angle) &&
                    line.Count == 2)
                {
                    TransformationMatrix matrix = TransformationMatrix.CreateRotationAroundLine(line[0], line[1], angle);
                    TransformPolyhedron(matrix);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Центральная":
                    currentProjectionMatrix = TransformationMatrix.PerspectiveProjection(5000);
                    IsPersp = true;
                    break;
                case "Аксонометрическая":
                    currentProjectionMatrix = TransformationMatrix.AxonometricProjection(45, 30);
                    IsPersp = false;
                    break;
            }
            pictureBox1.Invalidate();
        }
    }
}
