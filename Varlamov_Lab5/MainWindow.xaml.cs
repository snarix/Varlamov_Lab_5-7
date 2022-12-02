using System;
using System.Collections.Generic;
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
using Mans;
using Students;

namespace Varlamov_Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        Man _dude = new Man("Name", 15, "Gender", 100);
        Man _dude2 = new Man("Name", 15, "Gender", 100);

        private void Make(object sender, RoutedEventArgs e)
        {
            bool x = int.TryParse(age.Text, out int _age);
            bool y = int.TryParse(weight.Text, out int _weight);
            bool z = int.TryParse(name.Text, out int _name);

            if (x & y & !z & (gender.Text == "Male" || gender.Text == "Female"))
            {
                _dude.SetParams(name.Text, _age, gender.Text, _weight);

                NoTemplate.Text = _dude.Name + ", " + Convert.ToString(_dude.Age) + ", " + _dude.Gender + ", " + Convert.ToString(_dude.Weight);
                return;
            }

            MessageBox.Show("Ошибка");
        }

        private void MakeTemplate(object sender, RoutedEventArgs e)
        {
            _dude2.SetParams();
            Template.Text = _dude2.Name + ", " + Convert.ToString(_dude2.Age) + ", " + _dude2.Gender + ", " + Convert.ToString(_dude2.Weight);
        }


        private void AgeMore(object sender, RoutedEventArgs e)
        {
            _dude2++;
            Template.Text = _dude2.Name + ", " + Convert.ToString(_dude2.Age) + ", " + _dude2.Gender + ", " + Convert.ToString(_dude2.Weight);

        }

        private void BigOrLittle(object sender, RoutedEventArgs e)
        {
            if (Template.Text == "" || NoTemplate.Text == "")
            {
                MessageBox.Show("Создайте человека для сравнения");
            }
            else
            {
                if (_dude > _dude2)
                {
                    MessageBox.Show("У первого человека вес больше");
                }
                else
                {
                    MessageBox.Show("У второго человека вес больше");
                }
            }
        }

        Student _student = new Student("John", 18, "Male", 65, "09.07.20", 1, 101);

        private void MakeStudent(object sender, RoutedEventArgs e)
        {
            if (faculty.Text == null || !int.TryParse(course.Text, out int _course) || !int.TryParse(group.Text, out int _group))
            {
                MessageBox.Show("Ошибка");
                return;
            }
            _student.SetParam(faculty.Text, _course, _group);
            StudentNoTemplate.Text = _student.Faculty + ", " + _student.Course + ", " + _student.Group;
        }

        private void NextGroup(object sender, RoutedEventArgs e)
        {
            _student--;
            StudentNoTemplate.Text = _student.Faculty + ", " + _student.Course + ", " + _student.Group;
        }

        private void NextCourse(object sender, RoutedEventArgs e)
        {
            _student++;
            StudentNoTemplate.Text = _student.Faculty + ", " + _student.Course + ", " + _student.Group;
        }

        private void AboutProgramm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Варламов Артём Александрович. ИСП-34. Задание: Создать класс Man (человек), с полями: имя, возраст, пол и вес. " +
                "\r\nСоздать необходимые методы и свойства. " +
                "\r\nСоздать перегруженные методы SetParams, для установки параметров человека.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
