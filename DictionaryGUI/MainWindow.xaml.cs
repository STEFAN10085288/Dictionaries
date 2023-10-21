using prjDictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

namespace DictionaryGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string print(Dictionary<string, Student> dic)
        {
            string Output = " ";
            foreach (var i in dic)
            {
               Output = i.Value.ToString() +i.Key.ToString(); 
            }
            return Output; 
        }
        Dictionary<string, Student> keyValuePairs = new Dictionary<string, Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Student student = new Student();
            student.StrName = Name.Text; 
            student.StrSurname = Surname.Text;
            student.StrAge = Age.Text;
            student.StrGender1 = Gender.Text;
            keyValuePairs.Add(ID.Text,student);


             Block.Text = print(keyValuePairs); 



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         

            foreach (var item in keyValuePairs)
            {

                if (item.Value.StrName.Equals(deleteName.Text))
                {

                    keyValuePairs.Remove(item.Key);
                    MessageBox.Show(deleteName.Text + " deleted");
                    Block.Text = Block.Text +  print(keyValuePairs);

                }
                else
                {
                    MessageBox.Show(deleteName.Text + " not found");
                }

            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
