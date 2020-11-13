import { TedTalkService } from "../../shared/service/tedTalk.service";
import { TedTalk } from "../../shared/model/TedTalk.model";
import { Component } from '@angular/core';


@Component({
    selector: 'app-ted-talk',
    templateUrl: './ted-talk.component.html'
})
export class TedTalkComponent {

    /*displayDialog: boolean;

    talk: TedTalk = { title: '', link: '', id: null, isWatched: false };

    selectedCar: TedTalk;

    newTalk: boolean;*/

    talks: TedTalk[];

    constructor(private tedTalkService: TedTalkService) { }

    ngOnInit() {
        this.tedTalkService.getAllTedTalks().then(cars => this.talks = cars);
    }

    public addToFavorite(talk: TedTalk): any { }

    public watchTalk(talk: TedTalk): any { }

    public reRatchTalk(talk: TedTalk): any { }

    public save(): void { }

    showDialogToAdd() {
        /*this.newTalk = true;
        this.talk;
        this.displayDialog = true;*/
    }
}
