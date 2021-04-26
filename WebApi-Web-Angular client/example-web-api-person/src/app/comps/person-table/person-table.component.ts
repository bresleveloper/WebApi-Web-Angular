import { Component, OnInit } from '@angular/core';
import { Person } from 'src/app/models/person';
import { PersonService } from 'src/app/services/person.service';

@Component({
  selector: 'app-person-table',
  templateUrl: './person-table.component.html',
  styleUrls: ['./person-table.component.css']
})
export class PersonTableComponent implements OnInit {

  constructor(public ps:PersonService) { }

  persons:Person[] | undefined

  ngOnInit(): void {
    this.ps.getAllPersons().subscribe(all => this.persons = all)
  }

}
