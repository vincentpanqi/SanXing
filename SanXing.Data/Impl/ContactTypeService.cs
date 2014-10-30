﻿// <autogenerated>
//   This file was generated by T4 code generator Main.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using Mt.Core;
using Mt.Core.Data;
using SanXing.Data.Models;
using SanXing.Data.Service;

namespace SanXing.Data.Impl
{
    public partial class ContactTypeService : IContactTypeService
    {

        #region Fields

        private readonly IRepository<ContactType> _ContactTypeRepository;

        #endregion

        #region Ctor

        public ContactTypeService(IRepository<ContactType> ContactTypeRepository
           )
        {
            this._ContactTypeRepository = ContactTypeRepository;

        }

        #endregion

        public ContactType Single(int ID)
        {
            if (ID == 0)
                return null;

            return _ContactTypeRepository.GetById(ID);
        }

        public void Delete(ContactType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("ContactType");

            entity.Deleted = true;
            Update(entity);
        }

        public IPagedList<ContactType> GetAll(int pageIndex, int pageSize, bool showHidden = false)
        {
            var query = _ContactTypeRepository.Table;
            if (!showHidden)
                query = query.Where(a => !a.Deleted);
            query = query.OrderByDescending(a => a.ID);

            var result = new PagedList<ContactType>(query, pageIndex, pageSize);
            return result;
        }

        public IQueryable<ContactType> GetAll()
        {
            return _ContactTypeRepository.Table;
        }

        public void Insert(ContactType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("ContactType");
            _ContactTypeRepository.Insert(entity);
        }

        public void Update(ContactType entity)
        {
            if (entity == null)
                throw new ArgumentNullException("ContactType");

            _ContactTypeRepository.Update(entity);
        }
    }
}

