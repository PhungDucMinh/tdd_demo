using TDDDemo.Core.Exceptions;

namespace TDDDemo.Core
{
    public class EmployeeParser
    {
        public string[] Split(string content)
        {
            return content.Split('|');
        }

        public Employee ParseEmployee(string content)
        {
            string[] splitContents = Split(content);

            if (string.IsNullOrEmpty(splitContents[0]))
            {
                throw new MissingInformationImportException(Constants.CITIZEN_ID_PARAMETER_NAME);
            }

            if (string.IsNullOrEmpty(splitContents[4]))
            {
                throw new MissingInformationImportException(Constants.DEPARTMENT_ID_PARAMETER_NAME);
            }

            return new Employee
            {
                CitizenId = splitContents[0],
                FirstName = splitContents[1],
                LastName = splitContents[2],
                Age = string.IsNullOrEmpty(splitContents[3]) ? new int?() : int.Parse(splitContents[3]),
                DepartmentId = int.Parse(splitContents[4])
            };
        }


    }
}
