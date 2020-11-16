import sys
from bs4 import BeautifulSoup
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
from webdriver_manager.chrome import ChromeDriverManager
class Xpath_Util:
    def __init__(self):
        self.elements = None
        self.guessable_elements = ['input','button']
        self.known_attribute_list = ['id','name','placeholder','value','title','type','class']
        self.found = list()
        
    def generate_xpath(self,soup):
        result_flag = False
        try:
            for guessable_element in self.guessable_elements:
                self.elements = soup.find_all(guessable_element)                                
                for element in self.elements:                                   
                    if (not element.has_attr("type")) or (element.has_attr("type") and element['type'] != "hidden"):
                        for attr in self.known_attribute_list:                                                      
                            if element.has_attr(attr):                                                             
                                locator = self.guess_xpath(guessable_element,attr,element)                               
                                if len(driver.find_elements_by_xpath(locator))==1:
                                    result_flag = True                                   
                                    self.found.append(locator)
                                    break
                            elif guessable_element == 'button' and element.getText():                                                                  
                                button_text = element.getText()
                                if element.getText() == button_text.strip():
                                    locator = xpath_obj.guess_xpath_button(guessable_element,"text()",element.getText())
                                else:
                                    locator = xpath_obj.guess_xpath_using_contains(guessable_element,"text()",button_text.strip())
                                if len(driver.find_elements_by_xpath(locator))==1:
                                    result_flag = True                                   
                                    self.found.append(locator)
                                    break        
        except Exception as e:
            print ("Exception when trying to generate xpath for:%s"%guessable_element)
            print ("Python says:%s"%str(e))                                                 
        return result_flag
 
    def guess_xpath(self,tag,attr,element):
        if type(element[attr]) is list:
            element[attr] = [i.encode('utf-8') for i in element[attr]]
            element[attr] = ' '.join(element[attr])                             
        self.xpath = "//%s[@%s='%s']"%(tag,attr,element[attr])
        return  self.xpath            
 
    def guess_xpath_button(self,tag,attr,element):
        self.button_xpath = "//%s[%s='%s']"%(tag,attr,element)
        return  self.button_xpath
 
    def guess_xpath_using_contains(self,tag,attr,element):
        self.button_contains_xpath = "//%s[contains(%s,'%s')]"%(tag,attr,element)
        return self.button_contains_xpath
    
if __name__ == "__main__":
    url = sys.argv[1]
    
    options = Options()
    options.headless = True
    options.add_experimental_option('excludeSwitches', ['enable-logging'])
    driver = webdriver.Chrome(ChromeDriverManager().install(),options = options)
    driver.get(url)
    
    xpath_obj = Xpath_Util()
  
  
    page = driver.execute_script("return document.body.innerHTML").encode('utf-8') #returns the inner HTML as a string
    soup = BeautifulSoup(page, 'html.parser')
     
    if xpath_obj.generate_xpath(soup) is False:
        print ("No XPaths generated for the URL:%s"%url)
    driver.quit()  
    for i in xpath_obj.found:
        print(i)        
   
    