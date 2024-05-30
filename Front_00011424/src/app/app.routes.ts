import { Routes } from '@angular/router';
import { AllSongsComponent } from '../components/all-songs/all-songs.component';
import { AllAlbumsComponent } from '../components/all-albums/all-albums.component';
import { AddSongComponent } from '../components/add-song/add-song.component';
import { AddAlbumComponent } from '../components/add-album/add-album.component';

export const routes: Routes = [
    {
        path: "",
        component: AllSongsComponent
    },
    {
        path: "songs",
        component: AllSongsComponent
    },
    {
        path: "albums",
        component: AllAlbumsComponent
    },
    {
        path: "add-song",
        component: AddSongComponent
    },
    {
        path: "add-album",
        component: AddAlbumComponent
    }
];
