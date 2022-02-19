using System.Windows;

namespace SingletonFabrica
{

    public partial class MainWindow : Window
    {
        IClone personoid = new Person()
        {
            Id = "T - 800",
            Name = "Personoid"
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FactoryClones factoryClones = FactoryClones.GetInstance();
            MessageBox.Show(factoryClones.Say(personoid), "Personoid " + ((Person)personoid).Id, MessageBoxButton.OKCancel);
        }

        // Clone
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FactoryClones factoryClones = FactoryClones.GetInstance();
            IClone person = new Person();
            person = personoid.Clone();

            ((Person)personoid).Name = "Не personoid";// Изменяем глобальную переменную для этого(MainWindow) класса, personoid.name

            if (((Person)personoid).Name != ((Person)person).Name) // Если имя изменилось в персон - это значит что мы не смогли склонировать персонойда
            {
                MessageBox.Show(factoryClones.Say(person), "Personoid " + ((Person)person).Id, MessageBoxButton.OKCancel);
            }
            else
                MessageBox.Show("Ошибка скопировалась ссылка");

            ((Person)personoid).Name = "Personoid";
        }


        // SuperClone
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            FactoryClones factoryClones = FactoryClones.GetInstance();
            IClone person = new Person();

            person = personoid.SuperClone();

            ((Person)personoid).Name = "Не personoid";// Изменяем глобальную переменную для этого(MainWindow) класса, personoid.name

            if (((Person)personoid).Name != ((Person)person).Name) // Если имя изменилось в персон - это значит что мы не смогли склонировать персонойда
            {
                MessageBox.Show(factoryClones.Say(person), "Personoid " + ((Person)person).Id, MessageBoxButton.OKCancel);
            }
            else
                MessageBox.Show("Ошибка скопировалась ссылка");

            ((Person)personoid).Name = "Personoid";
        }
    }
}
