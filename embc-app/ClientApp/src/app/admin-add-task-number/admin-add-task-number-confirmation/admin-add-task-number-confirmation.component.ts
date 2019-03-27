import { Component, OnInit } from '@angular/core';
import { IncidentTask } from 'src/app/core/models';
import { Store } from '@ngrx/store';
import { AppState } from 'src/app/store';
import { takeWhile } from 'rxjs/operators';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-add-task-number-confirmation',
  templateUrl: './admin-add-task-number-confirmation.component.html',
  styleUrls: ['./admin-add-task-number-confirmation.component.scss']
})
export class AdminAddTaskNumberConfirmationComponent implements OnInit {
  componentActive = true;
  currentIncidentTask$ = this.store.select(s => s.incidentTasks.currentIncidentTask);

  incidentTask: IncidentTask;

  constructor(
    private store: Store<AppState>,
    private router: Router,
  ) { }

  ngOnInit() {
    this.currentIncidentTask$.pipe(takeWhile(() => this.componentActive))
      .subscribe(i => {
        // if there are any mandatory fields that are null route back to the main component
        if (!i.taskNumber || !i.community || !i.details) {
          this.router.navigate(['add-task-number']);
        } else {
          // we have somethings to show so we show it.
          this.incidentTask = i;
        }
      });
  }
  back() {
    // go back
    this.router.navigate(['add-task-number']);
  }
}
