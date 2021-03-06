/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModelProperty;

import java.util.Objects;

/**
 * ConditionCheckValueSettings
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class ConditionCheckValueSettings {
  @SerializedName("date")
  private DateCondition date = null;

  @SerializedName("number")
  private NumberCondition number = null;

  @SerializedName("text")
  private TextCondition text = null;

  @SerializedName("boolean")
  private BooleanCondition _boolean = null;

  public ConditionCheckValueSettings date(DateCondition date) {
    this.date = date;
    return this;
  }

   /**
   * Get date
   * @return date
  **/
  @ApiModelProperty(value = "")
  public DateCondition getDate() {
    return date;
  }

  public void setDate(DateCondition date) {
    this.date = date;
  }

  public ConditionCheckValueSettings number(NumberCondition number) {
    this.number = number;
    return this;
  }

   /**
   * Get number
   * @return number
  **/
  @ApiModelProperty(value = "")
  public NumberCondition getNumber() {
    return number;
  }

  public void setNumber(NumberCondition number) {
    this.number = number;
  }

  public ConditionCheckValueSettings text(TextCondition text) {
    this.text = text;
    return this;
  }

   /**
   * Get text
   * @return text
  **/
  @ApiModelProperty(value = "")
  public TextCondition getText() {
    return text;
  }

  public void setText(TextCondition text) {
    this.text = text;
  }

  public ConditionCheckValueSettings _boolean(BooleanCondition _boolean) {
    this._boolean = _boolean;
    return this;
  }

   /**
   * Get _boolean
   * @return _boolean
  **/
  @ApiModelProperty(value = "")
  public BooleanCondition getBoolean() {
    return _boolean;
  }

  public void setBoolean(BooleanCondition _boolean) {
    this._boolean = _boolean;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ConditionCheckValueSettings conditionCheckValueSettings = (ConditionCheckValueSettings) o;
    return Objects.equals(this.date, conditionCheckValueSettings.date) &&
        Objects.equals(this.number, conditionCheckValueSettings.number) &&
        Objects.equals(this.text, conditionCheckValueSettings.text) &&
        Objects.equals(this._boolean, conditionCheckValueSettings._boolean);
  }

  @Override
  public int hashCode() {
    return Objects.hash(date, number, text, _boolean);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ConditionCheckValueSettings {\n");
    
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    number: ").append(toIndentedString(number)).append("\n");
    sb.append("    text: ").append(toIndentedString(text)).append("\n");
    sb.append("    _boolean: ").append(toIndentedString(_boolean)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

