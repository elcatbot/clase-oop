import { Routes } from '@angular/router';
import { Home } from './home/home';
import { App } from './app';
import { Login } from './login/login';

export const routes: Routes = [
    { path: 'login', component: Login},
    { path: 'home', component: Home}
];
