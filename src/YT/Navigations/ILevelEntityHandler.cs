using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Navigations
{
  public  interface ILevelEntityHandler<T> where T :ITreeLevel
  {
        void Create(T t);
   

          void Update(T t);

          void Delete(T t, Action<T> action = null);

         IEnumerable<T> GetAllRoot();

         IEnumerable<T> GetChilds(T t);

         IEnumerable<T> GetParentChilds(T t);

         IEnumerable<T> GetAllChilds(T t);
        void UpdateParent(T t);
  }
}
