/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Controllers;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.Controller;

/**
 *
 * @author Richard
 */
public class HelloWorldController  implements Controller  {

    @Override
    public ModelAndView handleRequest(HttpServletRequest hsr, HttpServletResponse hsr1) throws Exception {
        		String aMessage = "Hello World MVC!";
 
		ModelAndView modelAndView = new ModelAndView("helloWorld");
		modelAndView.addObject("message", aMessage);
 
		return modelAndView;
    }
    
}
