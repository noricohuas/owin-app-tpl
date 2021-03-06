﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using Beginor.AppFx.Core;
using Beginor.OwinApp.Data.Repository;
using Beginor.OwinApp.Model;

namespace Beginor.OwinApp.Logic {

    public class SampleManager : Disposable, ISampleManager {

        private ISampleRepository repo;

        public SampleManager(ISampleRepository repo) {
            this.repo = repo;
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                repo = null;
            }
            base.Dispose(disposing);
        }

        public IList<SampleModel> GetAll() {
            var task = repo.GetAllAsync();
            task.Wait();
            return task.Result.AsQueryable()
               .ProjectTo<SampleModel>().ToList();
        }

    }

}
