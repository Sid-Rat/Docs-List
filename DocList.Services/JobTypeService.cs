using DocList.Data;
using DocList.Data.Migrations;
using DocList.Models.JobTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocList.Services
{
    public class JobTypeService : IJobTypeService
    {
        private readonly ApplicationDbContext _context;
        public JobTypeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<JobTypesIndexModel> GetJobTypes()
        {
            var jobTypes = _context.JobTypes
                .Select(d => new JobTypesIndexModel()
                    {
                        Id = d.Id,
                        Name = d.Name,
                        Deadline = d.Deadline,
                        Description = d.Description,
                    }).ToList();
            return jobTypes;
        }

        public JobTypesDetailModel GetJobTypeById(int Id)
        {
            var getJobType = _context.JobTypes
                .SingleOrDefault(d => d.Id == Id);
            return new JobTypesDetailModel()
            {
                Name = getJobType.Name,
                Deadline = getJobType.Deadline,
                Description = getJobType.Description,
                Id = getJobType.Id,

            };
        }
        public bool CreateJobTypes(JobTypesCreateModel model)
        {
            var jobTypes = new DocList.Data.JobType
            {
                Name = model.Name,
                Deadline = model.Deadline,
                Description = model.Description,
            };

            _context.JobTypes.Add(jobTypes);
            return (_context.SaveChanges() ==1);
        }
        public bool EditJobTypes(JobTypesEditModel model)
        {
            var jobType = _context.JobTypes
                .Single(f => f.Id == model.Id);
            jobType.Description = model.Description;
            jobType.Deadline = model.Deadline;
            jobType.Name = model.Name;

            return (_context.SaveChanges() == 1);
        }
        public IEnumerable<JobTypesDetailModel> DetailJobJypes()
        {
            var jobTypes = _context.JobTypes
                .Select(g => new JobTypesDetailModel()
                {
                    Name = g.Name,
                    Deadline = g.Deadline,
                    Description = g.Description,
                }).ToList();
            return jobTypes;
        }

    }
    }

