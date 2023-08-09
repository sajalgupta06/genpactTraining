import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ourApp';
  teams:any[] = [
    {
      tid:1,
      tName:"Team 1",
      tInfo:"Team Info 1",
      tEmail:"team@gmail.com",
      tSlogan:"Team 1 Slogan",
      iplTitle:2,
      tLogo:"https://images.unsplash.com/photo-1624526267942-ab0ff8a3e972?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8Y3JpY2tldCUyMHRlYW18ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
    },
     {
      tid:2,
      tName:"Team 2",
      tInfo:"Team Info 2",
      tSlogan:"Team 2 Slogan",
      tEmail:"team@gmail.com",
      iplTitle:1,
      tLogo:"https://images.unsplash.com/photo-1624526267942-ab0ff8a3e972?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8Y3JpY2tldCUyMHRlYW18ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
    },
     {
      tid:3,
      tName:"Team 3",
      tInfo:"Team Info 3",
      tEmail:"team@gmail.com",

      tSlogan:"Team 3 Slogan",
      iplTitle:2,
      tLogo:"https://images.unsplash.com/photo-1624526267942-ab0ff8a3e972?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8Y3JpY2tldCUyMHRlYW18ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
    },
     {
      tid:4,
      tName:"Team 4",
      tEmail:"team@gmail.com",
      tInfo:"Team Info 4",
      tSlogan:"Team 4 Slogan",
      iplTitle:1,
      tLogo:"https://images.unsplash.com/photo-1624526267942-ab0ff8a3e972?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8Y3JpY2tldCUyMHRlYW18ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
    },
     {
      tid:5,
      tName:"Team 5",
      tInfo:"Team Info 5",
      tEmail:"team@gmail.com",
      tSlogan:"Team 5 Slogan",
      iplTitle:1,
      tLogo:"https://images.unsplash.com/photo-1624526267942-ab0ff8a3e972?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8Y3JpY2tldCUyMHRlYW18ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
    }
  ]
}
