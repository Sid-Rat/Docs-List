using DocList.Models.JobTypes;

namespace DocList.Services
{
    public interface IJobTypeService
    {
        bool CreateJobTypes(JobTypesCreateModel model);
        IEnumerable<JobTypesDetailModel> DetailJobJypes();
        bool EditJobTypes(JobTypesEditModel model);
        IEnumerable<JobTypesIndexModel> GetJobTypes();
        JobTypesDetailModel GetJobTypeById(int Id);
    }
}