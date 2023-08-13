import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  title = "Match Maker";
  allusers: any;

  constructor(private http: HttpClient) { }
  ngOnInit(): void {

    this.http.get("https://localhost:44456/api/users").subscribe(
      {
        next: result => this.allusers = result,
        error: error => console.log(error),
        complete: () => console.log("Process completed")
      })
        
    }
}
