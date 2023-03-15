import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  today:Date = new Date();
  numberOfDay = this.today.getDay();
  progress = (this.numberOfDay*100)/7;

  constructor() { }

  ngOnInit(): void {
  }

}
