using System.Collections.Generic;

namespace PBL.BLL
{
    public interface ICrudBLL<T>
    {
        bool Create(params T[] items);
        bool Update(T item);
        bool Delete(params int[] ids);
        List<T> GetAll();
        T Get(int id);
    }
}
