# type: ignore
"""Welcome to Pynecone! This file outlines the steps to create a basic app."""
from pcconfig import config
import datetime
import pynecone as pc


class State(pc.State):
    day = int(0)
    month = int(0)
    year = int(0)
    valid = "Invalid"
    weekday = "Invalid"
    def is_date_valid(self, i):
        try:
            newDate = datetime.datetime(int(self.year), int(self.month), int(self.day))
            self.valid = "Valid"
            if newDate.weekday() == 0:
                self.weekday = "Monday"
            if newDate.weekday() == 1:
                self.weekday = "Tuesday"
            if newDate.weekday() == 2:
                self.weekday = "Wednesday"
            if newDate.weekday() == 3:
                self.weekday = "Thursday"
            if newDate.weekday() == 4:
                self.weekday = "Friday"
            if newDate.weekday() == 5:
                self.weekday = "Saturday"
            if newDate.weekday() == 6:
                self.weekday = "Sunday"
        except ValueError:
            self.valid = "Invalid"
            self.weekday = "Invalid"
    pass



def index() -> pc.Component:
    return pc.center(
        pc.stack(
        pc.heading("Is this a real day?", font_size="2em"),
        pc.text("Date: " + State.day + "/" + State.month + "/" + State.year, font_size="2em"),
        pc.heading("State: " + State.valid, font_size="2em"),
        pc.heading("Weekday: " + State.weekday, font_size="2em"),
        pc.heading("Day: ", font_size="md"),
        pc.editable(
            pc.editable_preview(),
            pc.editable_textarea(),
            placeholder="Day",
            on_change=State.set_day,
            on_submit=State.is_date_valid,
            width="100%",
        ),
        pc.heading("Month: ", font_size="md"),
        pc.editable(
            pc.editable_preview(),
            pc.editable_textarea(),
            placeholder="Month",
            on_change=State.set_month,
            on_submit=State.is_date_valid,
            width="100%",
        ),
        pc.heading("Year: ", font_size="md"),
        pc.editable(
            pc.editable_preview(),
            pc.editable_textarea(),
            placeholder="Year",
            on_change=State.set_year,
            on_submit=State.is_date_valid,
            width="100%",
        ),
        )
        
    )




# Add state and page to the app.
app = pc.App(state=State)
app.add_page(index)
app.compile()
