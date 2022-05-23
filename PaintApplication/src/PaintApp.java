import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;

 public class PaintApp extends JFrame implements MouseMotionListener {
    private int x = -10, y = -10;
    JLabel instructions = new JLabel("Drag the mouse to draw", JLabel.RIGHT);
    Container container = this.getContentPane();
    public PaintApp(){
        setTitle("Paint");
        setSize(800, 400);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        container.setLayout(new BorderLayout());
        container.add(instructions, BorderLayout.SOUTH);
        container.addMouseMotionListener(this);

        setVisible(true);
    }
    public void mouseDragged(MouseEvent event){
        x = event.getX();
        y = event.getY();
        repaint();
    }


     public void paint(Graphics graphics){
        graphics.fillOval(x, y, 4, 4);
    }
    public static void main(String arg[]){
        PaintApp paint = new PaintApp();
    }

}
