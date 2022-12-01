 @media screen and (min-width: 753px) {
      .box {
          display:table-cell;
          width: 49.2%;
          height: 280px;
      }
  }
  @media screen and (max-width: 752px) {
      .box {
          width: 100%;
      }
  }
        button.accordion {
            background-color: #ffffff;
            color: #444;
            cursor: pointer;
            padding: 10px;
            width: 100%;
            border: none;
            text-align: left;
            outline: none;
            font-size: 15px;
        }
        
     button.accordion.active {background-color: #d8ec9c;}
     
      button.accordion:hover {
            background-color: #aad728;
         
        }
        
        div.panel {
            padding: 0 10px;
            display: none;
            background-color: white;
    width: 100%;
        text-align: left;
        }
        
        div.panel.show {
            display: block !important;
        }
          button.accordion:after {
            content: '\02795'; /* Unicode character for "plus" sign (+) */
            font-size: 15px;
            color: #575757;
            float: left;
            padding-right: 10px;
            margin-left: 5px;
        }
        
        button.accordion.active:after {
            content: "\2796"; /* Unicode character for "minus" sign (-) */
        }