/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kerr_austin_finalexampart2;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.stage.Stage;

import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Arc;
import javafx.scene.shape.Ellipse;
import javafx.scene.shape.Line;
import javafx.scene.shape.Polygon;
import javafx.scene.Group;
import javafx.scene.layout.BorderPane;

public class Kerr_Austin_FinalExamPart2 extends Application {
    
    public static void main(String[] args) {
        launch(args);
    }
    
     @Override
    public void start(Stage primaryStage) {

        Circle circle = new Circle();
        circle.setCenterX(100);
        circle.setCenterY(100);
        circle.setRadius(80);
        circle.setStroke(Color.RED);
        circle.setFill(Color.PINK);
        
        Circle circle1 = new Circle(70, 70, 10);
        Circle circle2 = new Circle(130, 70, 10);
        
        Ellipse ellipse1 = new Ellipse(70, 70, 20, 15);
        ellipse1.setFill(Color.WHITE);
        ellipse1.setStroke(Color.BLACK);
        
        Ellipse ellipse2 = new Ellipse(130, 70, 20, 15);
        ellipse2.setFill(Color.WHITE);
        ellipse2.setStroke(Color.BLACK);
        
        Line line1 = new Line(100, 80, 80, 120);
        Line line2 = new Line(80, 120, 120, 120);
        Line line3 = new Line(120, 120, 100, 80);
        
        Arc arc = new Arc(100, 130, 40, 15, 180, 180);
        arc.setFill(Color.WHITE);
        arc.setStroke(Color.BLACK);
        
        Polygon polygon = new Polygon(50, 180, 50, 400, 150, 400, 150, 180);
        polygon.setFill(Color.RED);
        polygon.setStroke(Color.BLACK);
        
        Polygon polygon1 = new Polygon(30, 180, 30, 320, 60, 320, 60, 180);
        polygon1.setFill(Color.RED);
        polygon1.setStroke(Color.BLACK);
        Polygon polygon2 = new Polygon(30, 290, 30, 320, 60, 320, 60, 290);
        polygon2.setFill(Color.PINK);
        polygon2.setStroke(Color.BLACK);
        
        Polygon polygon3 = new Polygon(140, 180, 140, 320, 170, 320, 170, 180);
        polygon3.setFill(Color.RED);
        polygon3.setStroke(Color.BLACK);
        Polygon polygon4 = new Polygon(140, 290, 140, 320, 170, 320, 170, 290);
        polygon4.setFill(Color.PINK);
        polygon4.setStroke(Color.BLACK);
        
        Polygon polygon5 = new Polygon(50, 300, 50, 450, 150, 450, 150, 300);
        polygon5.setFill(Color.BLUE);
        polygon5.setStroke(Color.BLACK);
        
        Line line4 = new Line(100, 450, 100, 330);
        
        Polygon polygon6 = new Polygon(50, 410, 50, 450, 150, 450, 150, 410);
        
        Group group = new Group();
        group.getChildren().addAll(circle, ellipse1, ellipse2, circle1, circle2,
                line1, line2, line3, arc, polygon, polygon5, polygon1, polygon2, polygon3,
                polygon4, line4, polygon6);
        
        Scene scene = new Scene(new BorderPane(group), 400, 700);
        
        primaryStage.setTitle("Billybob Joe Bill Bobbybill Jameson");
        primaryStage.setScene(scene);
        primaryStage.show();
        
    }
   
}
