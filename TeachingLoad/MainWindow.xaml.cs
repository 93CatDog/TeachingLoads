
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TeachingLoadCore;
using TeachingLoadCore.ExcelIntegration;

namespace TeachingLoad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsChanged { get; set; }

        public List<Disciplines> disciplines { get; set; }
        public List<Teachers> teachers { get; set; }
        public List<Groups> groups { get; set; }


        public MainWindow()
        {
            InitializeComponent();


            UpdateDataGrids();
            
        }

        public void UpdateDataGrids()
        {
            using (var context = new TeachingLoadContext())
            {
                disciplines = context.Disciplines.ToList();
                this.DataGridDisciplines.ItemsSource = disciplines;
                //groups = context.Groups.ToList();
                //this.DataGridGroups.ItemsSource = groups;
                teachers = context.Teachers.ToList();
                this.DataGridTeachers.ItemsSource = teachers;
            }


        }



        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction != DataGridEditAction.Cancel)
            {
                this.IsChanged = true;
                this.DataGridDisciplines.CellEditEnding -= DataGrid_CellEditEnding;
                this.DataGridGroups.CellEditEnding -= DataGrid_CellEditEnding;
                this.DataGridTeachers.CellEditEnding -= DataGrid_CellEditEnding;
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            //Saving changes to DB
            if (this.IsChanged)
            {
                using (TeachingLoadContext context = new TeachingLoadContext())
                {
                    List<Disciplines> disciplines = (List<Disciplines>)this.DataGridDisciplines.ItemsSource;
                    context.Disciplines.UpdateRange(disciplines);

                    //List<Groups> groups = (List<Groups>)this.DataGridGroups.ItemsSource;
                    //context.Groups.UpdateRange(groups);

                    List<Teachers> teachers = (List<Teachers>)this.DataGridTeachers.ItemsSource;
                    context.Teachers.UpdateRange(teachers);

                    context.SaveChangesAsync();
                }
                this.IsChanged = false;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Window_Closing(this, new System.ComponentModel.CancelEventArgs());

            
        }

        //public void Test()
        // {
        //ExcelReader er = new ExcelReader(ExcelPaths.DisciplinesPath);
        //this.disciplines = er.ReadSheet();

        //using (var context = new TeachingLoadContext())
        //{
        //    //context.Disciplines.UpdateRange(disciplines);

        //    context.Disciplines.UpdateRange(disciplines);

        //    context.SaveChangesAsync();

        //    //disciplines = context.Disciplines.ToList();
        //    //this.DataGridDisciplines.ItemsSource = disciplines;
        //}
        //}

    }
}
