﻿namespace Nebuteater.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}