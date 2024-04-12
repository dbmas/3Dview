using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //创建第一个渲染器
            vtkRenderer renderer1 = vtkRenderer.New();

            // 创建第二个渲染器
            vtkRenderer renderer2 = vtkRenderer.New();

            // 创建第三个渲染器
            vtkRenderer renderer3 = vtkRenderer.New();

            // 创建圆柱体
            vtkCylinderSource cylinder = vtkCylinderSource.New();
            cylinder.SetRadius(50);
            cylinder.SetHeight(50);
            cylinder.SetResolution(100);

            // 创建圆球
            vtkSphereSource sphere = vtkSphereSource.New();
            sphere.SetRadius(50);
            sphere.SetThetaResolution(8);
            sphere.SetPhiResolution(8);

            // 创建圆锥
            vtkConeSource cone = vtkConeSource.New();
            cone.SetHeight(50);
            cone.SetRadius(50);
            cone.SetResolution(100);

            // 创建 mapper 和 actor 并添加到第一个渲染器中
            vtkPolyDataMapper mapper1 = vtkPolyDataMapper.New();
            mapper1.SetInputConnection(cylinder.GetOutputPort());
            vtkActor actor1 = vtkActor.New();
            actor1.SetMapper(mapper1);
            renderer1.AddActor(actor1);

            // 创建 mapper 和 actor 并添加到第二个渲染器中
            vtkPolyDataMapper mapper2 = vtkPolyDataMapper.New();
            mapper2.SetInputConnection(sphere.GetOutputPort());
            vtkActor actor2 = vtkActor.New();
            actor2.SetMapper(mapper2);
            renderer2.AddActor(actor2);

            // 创建 mapper 和 actor 并添加到第三个渲染器中
            vtkPolyDataMapper mapper3 = vtkPolyDataMapper.New();
            mapper3.SetInputConnection(cone.GetOutputPort());
            vtkActor actor3 = vtkActor.New();
            actor3.SetMapper(mapper3);
            renderer3.AddActor(actor3);
            // 将渲染器1设置在窗口左上角
            renderer1.SetViewport(0.0, 0.5, 0.5, 1.0);  // (xmin, ymin, xmax, ymax)

            // 将渲染器2设置在窗口右上角
            renderer2.SetViewport(0.5, 0.5, 1.0, 1.0);  // (xmin, ymin, xmax, ymax)

            // 将渲染器3设置在窗口底部
            renderer3.SetViewport(0.0, 0.0, 1.0, 0.5);  // (xmin, ymin, xmax, ymax)
            /*在VTK中，一个渲染窗口（vtkRenderWindow）可以包含多个渲染器（vtkRenderer），但是默认情况下，这些渲染器会在渲染窗口的(0, 0, 1, 1)区域中重叠显示。
             * 这就导致只有最后一个添加到渲染窗口中的渲染器的内容能够被正常显示，因为它覆盖了其他渲染器的内容
            要在一个渲染窗口中显示多个渲染器的内容，你需要调整每个渲染器的视口（Viewport），使它们在渲染窗口中的不同区域显示。你可以使用 SetViewport 方法来设置视口。*/
            // 将渲染器添加到 vtk 渲染窗口中

            renderer1.GetActiveCamera().SetPosition(0, -100, 0);
            renderer1.GetActiveCamera().SetFocalPoint(0, 0, 0);
            renderer1.GetActiveCamera().SetViewUp(0, 0, 1);

            // 设置第二个渲染器的相机视角
            renderer2.GetActiveCamera().SetPosition(0, 0, 100);
            renderer2.GetActiveCamera().SetFocalPoint(0, 0, 0);
            renderer2.GetActiveCamera().SetViewUp(0, 1, 0);

            // 设置第三个渲染器的相机视角
            renderer3.GetActiveCamera().SetPosition(100, 0, 0);
            renderer3.GetActiveCamera().SetFocalPoint(0, 0, 0);
            renderer3.GetActiveCamera().SetViewUp(0, 0, 1);

            renderWindowControl1.RenderWindow.AddRenderer(renderer1);
            renderWindowControl1.RenderWindow.AddRenderer(renderer2);
            renderWindowControl1.RenderWindow.AddRenderer(renderer3);
            renderer2.SetActiveCamera(renderer1.GetActiveCamera());
            renderer3.SetActiveCamera(renderer1.GetActiveCamera());

        }

        /// <summary>
        /// 连接数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            DatabaseWindow databaseWindow= new DatabaseWindow();
            databaseWindow.Show();
        }
    }
}