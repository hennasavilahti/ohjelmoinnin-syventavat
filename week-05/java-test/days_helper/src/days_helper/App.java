package days_helper;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.stage.Stage;
import java.sql.Date;
import java.time.format.TextStyle;

import javafx.geometry.HPos;
import javafx.geometry.Pos;
import javafx.geometry.VPos;
import javafx.scene.control.Label;
import javafx.scene.control.Button;
import javafx.scene.layout.GridPane;
import javafx.scene.control.DatePicker;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;

public class App extends Application {


    @Override
    public void start(Stage primaryStage) throws Exception{
        primaryStage.setTitle("Days Helper");


        Label dateLabel = new Label("Date");
        Label categoryLabel = new Label("Category");
        Label descriptionLabel = new Label("Description");


        DatePicker datePicker = new DatePicker();


        ComboBox<String> comboBox = new ComboBox<>();

        comboBox.getItems().addAll(
            "Work",
            "School",
            "Freetime"
        );
        comboBox.setEditable(true);


        TextField textField = new TextField();


        Button addEventButton = new Button("Add Event");


        GridPane gridPane = new GridPane();

        gridPane.addRow(0, dateLabel, datePicker);
        gridPane.addRow(1, categoryLabel, comboBox);
        gridPane.addRow(2, descriptionLabel, textField);
        gridPane.add(addEventButton, 1, 3);

        gridPane.setHgap(20);
        gridPane.setVgap(10);
        gridPane.setAlignment(Pos.CENTER);
        GridPane.setHalignment(addEventButton, HPos.CENTER);


        Scene scene = new Scene(gridPane, 500, 250);
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    public static void main(String[] args){
        launch(args);
    }

}
