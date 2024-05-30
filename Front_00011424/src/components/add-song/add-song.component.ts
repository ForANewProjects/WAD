import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Song } from '../../models/song11424';
import { MusicService } from '../../music.service';
import { Router } from '@angular/router';
import { Album } from '../../models/album11424';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add-song',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './add-song.component.html',
  styleUrl: './add-song.component.css'
})
export class AddSongComponent implements OnInit {
  song: Song = {
    id: 0,
    name: "",
    durationInSeconds: 0,
    album: {
        id : 0,
        albumName : "",
        releasedDate : new Date()
    },
    artistName: "",
    genre: ""
  };
  albums: Album[] = [];

  service = inject(MusicService);
  router = inject(Router);

  ngOnInit(){
    this.service.getAllAlbums()
      .subscribe(
        reuslt => {
          this.albums = reuslt;
        }
      )
  }
  create(song: Song){
    this.service.addSong(song)
      .subscribe(
        result => {
          this.router.navigateByUrl("songs");
        }
      )
  }
}
