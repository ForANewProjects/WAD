import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { Song } from '../../models/song11424';
import { MusicService } from '../../music.service';
import { Album } from '../../models/album11424';

@Component({
  selector: 'app-all-albums',
  standalone: true,
  imports: [],
  templateUrl: './all-albums.component.html',
  styleUrl: './all-albums.component.css'
})
export class AllAlbumsComponent {
  service = inject(MusicService);
  router = inject(Router);
  albums: Album[] = [];

  ngOnInit(){
    this.service.getAllAlbums()
      .subscribe((result) => this.albums = result);
  }

  delete(id:number){
    this.service.deleteSong(id)
      .subscribe(result => window.location.reload());
  }
}
