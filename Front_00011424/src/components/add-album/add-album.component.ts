import { Component, inject } from '@angular/core';
import { Album } from '../../models/album11424';
import { Router } from '@angular/router';
import { MusicService } from '../../music.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-album',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-album.component.html',
  styleUrl: './add-album.component.css'
})
export class AddAlbumComponent {
  album: Album = {
    id: 0,
    albumName: "",
    releasedDate: new Date()
  };

  service = inject(MusicService);
  router = inject(Router);

  create(album: Album){
    this.service.addAlbum(album)
      .subscribe(
        result => {
          this.router.navigateByUrl("albums");
        }
      )
  }
}
