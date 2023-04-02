package hellofx;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.geometry.Pos;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import javafx.fxml.FXML;
import javafx.scene.control.Label;

public class Main extends Application {


    @Override
    public void start(Stage primaryStage) throws Exception{
        primaryStage.setTitle("OhSyTe VH 05");


        Label label = new Label();


        String javaVersion = System.getProperty("java.version");
        String javafxVersion = System.getProperty("javafx.version");

        label.setText("Hello, JavaFX " + javafxVersion + "\nRunning on Java " + javaVersion + "." + "\nHenna Sävilahti");

        label.setAlignment(Pos.CENTER);

        primaryStage.setScene(new Scene(label, 400, 300));
        primaryStage.show();
    }

    public static void main(String[] args){

        launch(args);
    }

}
