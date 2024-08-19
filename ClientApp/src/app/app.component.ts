import { Component,OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { GraphqlService } from './graphql.service';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
  books: any[]=[]
  students: any[]=[]
  constructor(private graphqlService: GraphqlService) { }

  ngOnInit() {
    this.graphqlService.fetchBooks().subscribe(response => {
      this.books = response.data.books; 
    })
  }
}
