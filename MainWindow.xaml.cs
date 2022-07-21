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

namespace EntityFrameworkCoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Data Source=DELICIA-ASUS-ZB;Initial Catalog=MSSQLOnlineShopdb;Integrated Security=True
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\delicia\Documents\MSAccessOnlineShopdb.accdb
        //'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook'
        //Scaffold-DbContext -Connection "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\database.mdb';Database Password=mypass" -Provider EntityFrameworkCore.Jet
        //Scaffold-DbContext "Server=.\DELICIA-ASUS-ZB;Database=MSSQLOnlineShopdb;Trusted_Connection=False;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
        //Scaffold-DbContext -Connection "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\delicia\Documents\MSAccessOnlineShopdb.accdb" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
    }
}
