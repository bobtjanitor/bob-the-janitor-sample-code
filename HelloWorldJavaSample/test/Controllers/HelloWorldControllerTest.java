package Controllers;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import static org.junit.Assert.*;
import org.junit.Before;
import org.junit.Test;
import org.springframework.web.servlet.ModelAndView;

public class HelloWorldControllerTest {
    
    public ModelAndView Actual;
    public HelloWorldController Target;
    HttpServletRequest hsr;
    HttpServletResponse hsr1;
    
    public HelloWorldControllerTest() {
        Target = new  HelloWorldController();
    }    
    
    @Before
    public void setUp() throws Exception {
        hsr = null;
        hsr1 = null;
        Actual = Target.handleRequest(hsr, hsr1);
    }
    
    @Test
    public void Has_Expected_View_Name_Test() {
        assertEquals(Actual.getViewName(), "helloWorld");
    }
    
    @Test
    public void Has_Expected_Model_Value_Test()
    {
        assertEquals(Actual.getModel().get("message"),"Hello World MVC!");
    }
}