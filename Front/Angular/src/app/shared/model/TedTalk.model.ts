import { Guid } from "guid-typescript";

export class TedTalk {
    public id: Guid;
    public title: string;
    public link: string;
    public isWatched: boolean;
}