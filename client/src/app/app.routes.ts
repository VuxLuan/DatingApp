import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MenberListComponent } from './members/menber-list/menber-list.component';
import { MenberDetailComponent } from './members/menber-detail/menber-detail.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { authGuard } from './_guards/auth.guard';

export const routes: Routes = [
    { path: '', component: HomeComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [authGuard],
        children: [
            { path: 'members', component: MenberListComponent, },
            { path: 'members/', component: MenberDetailComponent },
            { path: 'lists', component: ListsComponent },
            { path: 'messages', component: MessagesComponent },
        ]
    },
    { path: '**', component: HomeComponent, pathMatch: 'full' },

];
