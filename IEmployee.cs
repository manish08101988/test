using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{
   public interface IEmployee
    {
	//first function
         void GetEmployee();

		//2nd function
         void GetEmployeeByID(int ID);
		//3rd function
  void DeleteEmployeeByID(int ID);
//4rd function
  void AreyouInNewStagingBranch();


}
