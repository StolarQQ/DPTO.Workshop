import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"]
})
export class AppComponent implements OnInit {
  url = "https://localhost:5001/api/";

  cars = [];
  displayedColumns = ["name", "addedOn"];

  carName = "";

  constructor(private http: HttpClient) {

  }

  ngOnInit(): void {
    this.fetchCars();
  }

  private fetchCars() {
    this.http.get<any>(this.url + "cars").subscribe(res => this.cars = res);
  }

  addCar() {
    if (!!this.carName) {
      this.http.post(this.url + "cars", { Name: this.carName }).subscribe(() => { this.fetchCars(); this.carName = ""; });
    }
  }
}
