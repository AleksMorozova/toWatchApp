import { Guid } from "guid-typescript";

export class Book {
    public id: Guid;
    public title: string;
    public author: string;
    public description: string;
}
