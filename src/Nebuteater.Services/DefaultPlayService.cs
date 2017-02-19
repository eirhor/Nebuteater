﻿using System.Collections.Generic;
using Nebuteater.Data.Infrastructure;
using Nebuteater.Models.Entities;
using Nebuteater.Services.Interfaces;

namespace Nebuteater.Services
{
    public class DefaultPlayService : IDefaultPlayService
    {
        private readonly IRepository<Play> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DefaultPlayService(IRepository<Play> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Play GetPlay(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Play> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Play play)
        {
            _repository.Update(play);
        }

        public void Delete(Play play)
        {
            _repository.Delete(play);
        }

        public void Create(Play play)
        {
            _repository.Add(play);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}