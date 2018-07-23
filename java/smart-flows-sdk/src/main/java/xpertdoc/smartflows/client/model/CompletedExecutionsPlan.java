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
 * CompletedExecutionsPlan
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class CompletedExecutionsPlan {
  @SerializedName("schedule")
  private Schedule schedule = null;

  @SerializedName("internal")
  private CleanupActionSettings internal = null;

  @SerializedName("output")
  private CleanupActionSettings output = null;

  @SerializedName("full")
  private CleanupActionSettings full = null;

  public CompletedExecutionsPlan schedule(Schedule schedule) {
    this.schedule = schedule;
    return this;
  }

   /**
   * Get schedule
   * @return schedule
  **/
  @ApiModelProperty(value = "")
  public Schedule getSchedule() {
    return schedule;
  }

  public void setSchedule(Schedule schedule) {
    this.schedule = schedule;
  }

  public CompletedExecutionsPlan internal(CleanupActionSettings internal) {
    this.internal = internal;
    return this;
  }

   /**
   * Get internal
   * @return internal
  **/
  @ApiModelProperty(value = "")
  public CleanupActionSettings getInternal() {
    return internal;
  }

  public void setInternal(CleanupActionSettings internal) {
    this.internal = internal;
  }

  public CompletedExecutionsPlan output(CleanupActionSettings output) {
    this.output = output;
    return this;
  }

   /**
   * Get output
   * @return output
  **/
  @ApiModelProperty(value = "")
  public CleanupActionSettings getOutput() {
    return output;
  }

  public void setOutput(CleanupActionSettings output) {
    this.output = output;
  }

  public CompletedExecutionsPlan full(CleanupActionSettings full) {
    this.full = full;
    return this;
  }

   /**
   * Get full
   * @return full
  **/
  @ApiModelProperty(value = "")
  public CleanupActionSettings getFull() {
    return full;
  }

  public void setFull(CleanupActionSettings full) {
    this.full = full;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CompletedExecutionsPlan completedExecutionsPlan = (CompletedExecutionsPlan) o;
    return Objects.equals(this.schedule, completedExecutionsPlan.schedule) &&
        Objects.equals(this.internal, completedExecutionsPlan.internal) &&
        Objects.equals(this.output, completedExecutionsPlan.output) &&
        Objects.equals(this.full, completedExecutionsPlan.full);
  }

  @Override
  public int hashCode() {
    return Objects.hash(schedule, internal, output, full);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CompletedExecutionsPlan {\n");
    
    sb.append("    schedule: ").append(toIndentedString(schedule)).append("\n");
    sb.append("    internal: ").append(toIndentedString(internal)).append("\n");
    sb.append("    output: ").append(toIndentedString(output)).append("\n");
    sb.append("    full: ").append(toIndentedString(full)).append("\n");
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

