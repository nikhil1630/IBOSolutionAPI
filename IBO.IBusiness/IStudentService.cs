using IBO.Business.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.IBusiness
{
    public interface IStudentService
    {
        Task<StudentDTOs> GetAllStudentDetails();
        Task<StudentDTOs> GetAllStudentName();
        Task<StudentDTOs> GetStudentByID(int id);
       
    }
}
