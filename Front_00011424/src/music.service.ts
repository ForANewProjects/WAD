import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Song } from './models/song11424';
import { Album } from './models/album11424';

@Injectable({
  providedIn: 'root'
})
export class MusicService {
  httpClient = inject(HttpClient);
  constructor() { }

  getAllSongs(){
    return this.httpClient.get<Song[]>("http://localhost:5118/api/Song");
  }
  
  getAllAlbums(){
    return this.httpClient.get<Album[]>("http://localhost:5118/api/Album");
  }

  addAlbum(album: Album){
    return this.httpClient.post<Album>("http://localhost:5118/api/Album", album);
  }

  addSong(song: Song){
    return this.httpClient.post<Song>("http://localhost:5118/api/Song/", song);
  }

  deleteAlbum(id: number){
    return this.httpClient.delete<Album>("http://localhost:5118/api/Album/"+id);
  }

  deleteSong(id:number){
    return this.httpClient.delete<Song>("http://localhost:5118/api/Song/"+ id);
  }
}
