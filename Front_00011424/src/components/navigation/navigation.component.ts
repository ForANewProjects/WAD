import { Component, inject } from '@angular/core';
import { Router, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-navigation',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './navigation.component.html',
  styleUrl: './navigation.component.css'
})
export class NavigationComponent {
  router = inject(Router)

  AddSongClicked(){
    this.router.navigateByUrl("add-song")
  }

  AddAlbumClicked(){
    this.router.navigateByUrl("add-album")
  }

  SongsClicked(){
    this.router.navigateByUrl("songs")
  }

  AlbumsClicked(){
    this.router.navigateByUrl("albums")
  }
}
