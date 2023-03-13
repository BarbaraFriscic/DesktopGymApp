using GymApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp.Presenter
{
    public class MainPresenter
    {
            //Fields
            private IMainView mainView;
            //private IEmployeeView _employeeView;
            //private IEmployeeRepository _employeeRepository;
            //private string sqlConnectionString;
            //private ILocationView _locationView;
            //private ILocationRepository _locationRepository;
            //private IMemberView _memberView;
            //private IMemberRepository _memberRepository;

            //Constructor
            public MainPresenter(IMainView mainView)
            {
                this.mainView = mainView;
                //sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
                //_employeeView = EmployeeView.GetInstance((Form)mainView);
                //_employeeRepository = new EmployeeRepository(sqlConnectionString);
                //_locationView = LocationView.GetInstance((Form)mainView);
                //_locationRepository = new LocationRepository(sqlConnectionString);
                //_memberView = MemberView.GetInstance((Form)mainView);
                //_memberRepository = new MemberRepository(sqlConnectionString);


                //Subscribe event handler methods to view events
                this.mainView.LocationViewEvent += LocationViewPresent;
                this.mainView.MembersViewEvent += MembersViewPresent;
                this.mainView.MembershipPlansViewEvent += MembershipPlanViewPresent;
                this.mainView.EmployeesViewEvent += EmployeesViewPresent;
            }

            private void LocationViewPresent(object sender, EventArgs e)
            {
                //new LocationPresenter(_locationView, _locationRepository);
                //_locationView.Show();
                //_employeeView.Hide();
                //_memberView.Hide();
            }

            private void MembersViewPresent(object sender, EventArgs e)
            {
                //_memberView.Show();
                //_employeeView.Hide();
                //_locationView.Hide();
            }

            private void MembershipPlanViewPresent(object sender, EventArgs e)
            {

            }

            private void EmployeesViewPresent(object sender, EventArgs e)
            {
                //new EmployeePresenter(_employeeView, _employeeRepository);
                //_employeeView.Show();
                //_locationView.Hide();
                //_memberView.Hide();

            }
        }
    }

