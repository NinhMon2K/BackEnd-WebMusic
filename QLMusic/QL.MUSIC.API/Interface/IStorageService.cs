using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.API.Interface
{
    public interface IStorageService
    {

        string GetFileUrl(string fileName);

        Task<string> SaveFileAsync(Stream mediaBinaryStream, string fileName);

        Task DeleteFileAsync(string fileName);

    }
}
