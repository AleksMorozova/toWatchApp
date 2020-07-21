import { Guid } from "guid-typescript";

export class Movie {
    public id: Guid;
    public title: string;
    public link: string;
    public description: string;
    public isWatched: boolean;
}
