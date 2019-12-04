using ApplicationCore.Interfaces;
using System.Collections.Generic;
using ApplicationCore.Entities.DoctorAggregate;
using ApplicationCore.DTO;
using AutoMapper;
using ApplicationCore.Specifications;
namespace ApplicationCore.Services
{
    public class DoctorService: IDoctorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DoctorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<string> GetNames()
        {
            return _unitOfWork.Doctors.GetNames();
        }
         public Doctor GetDoctor(string id)
         {
             return _unitOfWork.Doctors.GetBy(id);
         }
         public IEnumerable<DoctorsDTO> GetDoctors(int pageIndexs, int pageSize, out int count)// out chi lay ra
         {
             count = 4; 
             var doctorSpecPaging = new DoctorSpecification(pageIndexs, pageSize);

            var doctors = _unitOfWork.Doctors.Find(doctorSpecPaging);
            return _mapper.Map<IEnumerable<Doctor>, IEnumerable<DoctorsDTO>>(doctors);
         }
         
         public void CreateDoctor(Doctor doctor)
         {
             
         }
         public void UpdateDoctor(Doctor doctor)
         {

         }
         public void DeleteDoctor(string id)
         {

         }

    }
}