export interface Song{
    id: number;
    name: string;
    durationInSeconds: number;
    album: {
        id : number;
        albumName : string;
        releasedDate : Date;
    };
    artistName: string;
    genre: string;
}