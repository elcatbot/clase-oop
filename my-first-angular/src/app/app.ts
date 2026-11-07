import { Component, signal } from '@angular/core';
import { Router, RouterOutlet } from '@angular/router';
import { Home } from './home/home';
import { Menu } from './menu/menu';

@Component({
  selector: 'app-root',
  imports: [ RouterOutlet, Menu],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  
}
