﻿using EducationProcess.DataAccess.Entities;
using EducationProcess.DataAccess.Repositories.Interfaces;

namespace EducationProcess.DataAccess.Repositories
{
    public class ReceivedSpecialtyRepository : RepositoryBase<ReceivedSpecialty>, IReceivedSpecialtyRepository
    {
        private readonly EducationProcessContext context;
        
        public ReceivedSpecialtyRepository(EducationProcessContext context) : base(context)
        {
            this.context = context;
        }
    }
}