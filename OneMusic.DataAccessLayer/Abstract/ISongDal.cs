﻿using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.DataAccessLayer.Abstract
{
    public interface ISongDal : IGenericDal<Song>
    {
        List<Song> GetSongsWithAlbumAndArtist(int id);

        List<Song> GetSongswithAlbumByUserId(int id);

        List<Song> GetSongsWithAlbum();

    }
}
