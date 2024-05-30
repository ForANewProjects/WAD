import { Component, inject } from '@angular/core';
import { MusicService } from '../../music.service';
import { Router } from '@angular/router';
import { Song } from '../../models/song11424';

@Component({
  selector: 'app-all-songs',
  standalone: true,
  imports: [],
  templateUrl: './all-songs.component.html',
  styleUrl: './all-songs.component.css'
})
export class AllSongsComponent {
  service = inject(MusicService);
  router = inject(Router);
  songs: Song[] = [];

  ngOnInit(){
    this.service.getAllSongs()
      .subscribe((result) => this.songs = result);
  }

  delete(id:number){
    this.service.deleteSong(id)
      .subscribe(result => window.location.reload());
  }
}
