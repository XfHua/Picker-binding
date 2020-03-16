using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App171
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            myModel m = new myModel();

            BindingContext = m;
        }
    }

    public class myModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        List<AdditionSort> testList = new List<AdditionSort>();

        public List<AdditionSort> TestList
        {
            get { return testList; }
            set
            {
                testList = value;
                OnPropertyChanged();
            }
        }

        public myModel() {

            LoadList();

        }

        void LoadList()
        {
            TestList.Add(new AdditionSort { Name = "test1" });
            TestList.Add(new AdditionSort { Name = "test2" });
        }
    }

    public class AdditionSort
    {       
        public string Name { get; set; }
    }
}
