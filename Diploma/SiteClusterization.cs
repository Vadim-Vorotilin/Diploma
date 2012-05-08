using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    class SiteClusterization : Site
    {
        #region Overrides of Site

        protected override double Price
        {
            get { throw new NotImplementedException(); }
        }

        protected override void GoToNeighbour(Site site)
        {
            throw new NotImplementedException();
        }

        protected override Site GetNeighbour()
        {
            throw new NotImplementedException();
        }

        public override object Result
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
