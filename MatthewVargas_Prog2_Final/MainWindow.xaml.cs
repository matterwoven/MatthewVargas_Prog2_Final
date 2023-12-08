using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace MatthewVargas_Prog2_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<TaskItem> TaskItemsList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PopulateListView();

        }

        private void PopulateListView()
        {
            // Create some sample data
            TaskItem task1 = new TaskItem() { Name = "Task 1", HighImportance = "True", TimeSensitive = "True", Description = "Description 1", Completed = "Completed" };
            TaskItem task2 = new TaskItem() { Name = "Task 2", HighImportance = "False", TimeSensitive = "False", Description = "Description 2", Completed = "Not Completed" };

            // Add the tasks to the list
            TaskItemsList.Add(task1);
            TaskItemsList.Add(task2);

            // Set the list as the ItemsSource for the ListView
            DisplayedCategoryGrid.ItemsSource = TaskItemsList;
        }

        private void txtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {

            //Add txtTask.text to Column "Name" under current rows list
            //Add txtDescription.text to Column "Description" under current rows list
            //If Boxes and Radios are checked, make them true under current rows list
            string DescriptionText = txtDescription.Text;
            string Name = txtTaskName.Text;
            
            {
                // Create a new Tasklist with the values from text boxes and checkboxes
                TaskItem TaskItem = new TaskItem
                {
                    Name = Name,
                    HighImportance = CheckBoxHighImportance.IsChecked == true ? "True" : "False",
                    TimeSensitive = CheckBoxTimeSensitive.IsChecked == true ? "True" : "False",
                    Description = DescriptionText,
                    Completed = RadioCompleted.IsChecked == true ? "Completed" : "Not Completed"
                };

            }
        }


        private void btnUpdateSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            //Complete, no more work needed
            // When pressed if RadioNotCompleted is checked set column Completed to "Completed" in the selected row
            // When pressed if High Importance is checked set column High Importance to "True" in the selected row
            // When pressed if Time Sensitive is checked set column Completed to "True" in the selected row
            // When pressed string value of Description in the selected row is set to txtDescription.text
            // When pressed string value of Name in the selected row is set to txtTaskName

            var selectedItem = DisplayedCategoryGrid.SelectedItem as TaskItem;
            if (selectedItem != null)
            {
                selectedItem.Completed = RadioNotCompleted.IsChecked == true ? "Completed" : "";
                selectedItem.HighImportance = CheckBoxHighImportance.IsChecked == true ? "True" : "";
                selectedItem.TimeSensitive = CheckBoxTimeSensitive.IsChecked == true ? "True" : "";
                selectedItem.Description = txtDescription.Text;
                selectedItem.Name = txtTaskName.Text;
                DisplayedCategoryGrid.Items.Refresh();
            }
        }

        private void btnClearBoxes_Click(object sender, RoutedEventArgs e)
            {
                //Complete
                //When pressed set strings of columns Completed, Name, High Importance, Time Sensetive and Description to '' on selected row
                var selectedItem = DisplayedCategoryGrid.SelectedItem as TaskItem;
                if (selectedItem != null)
                {
                    selectedItem.Completed = "";
                    selectedItem.Name = "";
                    selectedItem.HighImportance = "";
                    selectedItem.TimeSensitive = "";
                    selectedItem.Description = "";
                }
            }

            private void RadioCompleted_Checked(object sender, RoutedEventArgs e)
            {

            }

            private void RadioNotCompleted_Checked(object sender, RoutedEventArgs e)
            {

            }

            private void CheckBoxTimeSensitive_Checked(object sender, RoutedEventArgs e)
            {

            }

            private void CheckBoxHighImportance_Checked(object sender, RoutedEventArgs e)
            {

            }

        //Moving to listview and text boxes

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //When row is selected get txtSummary to display selected row and its description in the format of 'Column: Column Description (New row) (repeat)'
            //Get the rich text box txtSummary to display each column from selected row and its description in the format of 'Column: Column Description (New row) (repeat)'
            // When a row is selected, get the selected Tasklist object
            TaskItem selectedTask = DisplayedCategoryGrid.SelectedItem as TaskItem;

            if (selectedTask != null)
            {
                // Create an instance of TaskFields and set its values
                TaskFields taskFields = new TaskFields();
                taskFields.TaskValues(selectedTask.Name, selectedTask.HighImportance, selectedTask.TimeSensitive, selectedTask.Description, selectedTask.Completed);

                // Create a new paragraph for the RichTextBox
                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(new Run(taskFields.DisplayInformation()));

                // Set the content of the RichTextBox
                txtSummary.Document.Blocks.Clear();
                txtSummary.Document.Blocks.Add(paragraph);
            }
        }
        private void txtSummary_TextChanged(object sender, TextChangedEventArgs e)
            {

            }

            private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
            {

            }

            private void txtTaskName_TextChanged(object sender, TextChangedEventArgs e)
            {

            }
            
            public void Preload()
            {
             //= new List<Tasklist>();

            
             
             
             
            }
            public void CreateNewCategory()
            {
             
             
             
             
             
            }

        public class TaskItem
        {
            public string Name { get; set; }
            public string HighImportance { get; set; }
            public string TimeSensitive { get; set; }
            public string Description { get; set; }
            public string Completed { get; set; }
        }
        private void NewCategory_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }




    }
    public class NewTask
    {
        public string? Completed { get; set; }
        public string? Name { get; set; }
        public string? HighImportance { get; set; }
        public string? TimeSensitive { get; set; }
        public string? Description { get; set; }

    }

    } 

